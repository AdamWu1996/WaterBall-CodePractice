using System.Collections.Generic;

namespace 參考水球UML
{
    public class Mission
    {
        private List<Scene> scenes;

        internal List<Scene> Scenes
        {
            get => scenes;
            set
            {
                this.scenes = value;
            }
        }

        public int calcExp()
        {
            foreach (Scene scene in Scenes)
            {

            }
            return 0;
        }
    }
}