using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ViewModel.Dialogs
{
  public class DialogsManager : IDisposable
  {
    private readonly List<DialogEntity<IDialogState>> _openedDialogs = new List<DialogEntity<IDialogState>>();
    private readonly Canvas _canvas;

    private class DialogEntity<T> where T : IDialogState
    {
      public DialogType Type;
      public IDialogContext<T> Context;
    }

    public DialogsManager(Canvas canvas)
    {
      _canvas = canvas;
    }

    public void Open(DialogType type, IDialogState state = null)
    {
      var entity = Create(type, state);
      _openedDialogs.Add(entity);
    }

    public void Close(DialogType type)
    {
      foreach (var dialogEntity in _openedDialogs.Where(d => d.Type == type))
      {
        dialogEntity.Context.Close();
      }
    }

    public void CloseAll()
    {
      _openedDialogs.ForEach(d => d.Context.Close());
    }

    private void SetCurrentState(IDialogState state)
    {
      if (_openedDialogs.Count == 0)
        return;

      var current = _openedDialogs.Last();
      current.Context.SetState(state);
    }

    private DialogEntity<IDialogState> Create(DialogType type, IDialogState state)
    {
      var name = type.GetPath();
      var dialog = Resources.Load<BaseDialogContext<IDialogState>>(name);
      var go = UnityEngine.Object.Instantiate(dialog, _canvas.transform);

      var entity = new DialogEntity<IDialogState>
      {
        Type = type,
        Context = go
      };
      go.Open(state);
      return entity;
    }

    public void Dispose()
    {
      _openedDialogs.ForEach(d => d.Context.Close());
    }
  }
}