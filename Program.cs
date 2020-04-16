using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System;
using VRage.Collections;
using VRage.Game.Components;
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game;
using VRage;
using VRageMath;

namespace IngameScript
{
    partial class Program : MyGridProgram
    {
        public Program()
        {
            Runtime.UpdateFrequency = UpdateFrequency.Once;
        }

        public void Save()
        {
            
        }

        public void Main(string argument, UpdateType updateSource)
        {
            IMyTextPanel Output = GridTerminalSystem.GetBlockWithName("Output") as IMyTextPanel;
            IMyTextPanel Liste = GridTerminalSystem.GetBlockWithName("Liste") as IMyTextPanel;

            string startIndex;

            if(argument.Length <= 2)
            {
                startIndex = argument;
            }
            else
            {
                startIndex = argument.Substring(2);
            }
            
            string test = Liste.GetText();

            if (Output != null)
            {
                Echo("Pannel found");
                if (test.Contains(startIndex) == true)
                {
                    Echo("Argument yes");
                    int index = test.IndexOf(startIndex);
                    int index2 = test.Length-index;
                    string result = test.Substring(index, index2);

                    int endIndex = result.IndexOf('e')+2;
                    string endResult = result.Substring(0, endIndex);

                    Output.WriteText(endResult);
                }
                else
                {
                    Echo("Argument no");
                }
            }
            else
            {
                Echo("pannel not found");
            }
        }
    }
}
