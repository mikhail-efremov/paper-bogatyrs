using Characters;
using Characters.Common;

namespace Dto
{
  public class CharacterDto
  {
    private CharacterClass _class;
    public CharacterClass Class => _class;

    private Damage _damage;
    public Damage Damage => _damage;

    private Threat _threat;
    public Threat Threat => _threat;

    private Critical _critical;
    public Critical Critical => _critical;

    private Initiate _initiate;
    public Initiate Initiate => _initiate;
  }
}