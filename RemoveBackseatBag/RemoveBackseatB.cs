using JaLoader;
using UnityEngine;

namespace RemoveBackseatBag
{
    public class RemoveBackseatBag : Mod
    {
        public override string ModID => "RemoveBackseatBag"; // The mod's ID. Try making it as unique as possible, to avoid conflitcting IDs.
        public override string ModName => "Remove Backseat Bag"; // The mod's name. This is shown in the mods list. Does not need to be unique.
        public override string ModAuthor => "Leaxx"; // The mod's author (you). Also shown in the mods list.
        public override string ModDescription => "Removes the bag from the backseat of the Laika"; // The mod's description. This is also shown in the mods list, upon clicking on "More Info".
        public override string ModVersion => "1.0.0"; // The mod's version. Also shown in the mods list. If your mod is open-source on GitHub, make sure that you're using the same format as your release tags (for example, 1.0.0)
        public override string GitHubLink => ""; // If your mod is open-source on GitHub, you can link it here to allow for automatic update-checking in-game. It compares the current ModVersion with the tag of the latest release (ex. 1.0.0 compared with 1.0.1)
        public override WhenToInit WhenToInit => WhenToInit.InGame; // When should the mod's OnEnable/Awake/Start/Update functions be called?

        public override void Start() // Default Unity Start() function
        {
            base.Start();

            ModHelper.Instance.laika.transform.Find("TweenHolder/Frame/backseatJunk").gameObject.SetActive(false);
        }
    }
}
