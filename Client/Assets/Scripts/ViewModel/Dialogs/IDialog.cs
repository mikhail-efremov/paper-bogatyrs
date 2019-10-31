namespace ViewModel.Dialogs
{
  public interface IDialogContext<T> where T : IDialogState
  {
    T CurrentState { get; }
    void Open(T state);
    void Close();

    void OnEnabled();
    void OnDisabled();

    void SetState(T state);
  }
}