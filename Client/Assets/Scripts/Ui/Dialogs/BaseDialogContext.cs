using UnityEngine;

namespace Ui.Dialogs
{
  public abstract class BaseDialogContext<T> : MonoBehaviour, IDialogContext<T> where T : IDialogState
  {
    public T CurrentState { get; private set; }

    public void Open(T state)
    {
      ChangeState(state);
    }

    public void Close() { }

    public virtual void OnEnabled() { }
    public virtual void OnDisabled() { }

    public void SetState(T state)
    {
      ChangeState(state);
    }

    private void ChangeState(T state)
    {
      CurrentState = state;
      OnStateChanged(CurrentState);
    }

    protected abstract void OnStateChanged(T state);
  }
}