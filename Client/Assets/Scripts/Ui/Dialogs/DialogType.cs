namespace Ui.Dialogs
{
  public enum DialogType
  {
    None,
    CharacterDetailsDialog
  }

  public static class DialogTypeUtils
  {
    private const string PathPrefix = @"Prefabs/Ui/Dialogs/";
    public static string GetPath(this DialogType type)
    {
      return $"{PathPrefix}{type}";
    }
  }
}