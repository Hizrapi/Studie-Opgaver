using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons
{
    internal class Training_Monsters // Få updated træningen.
    {
        private Random random = new Random();

        // Basic training with low energy and XP requirements
        public void Meditation(int dexterity)
        {
            int successRate = random.Next(0, 100);
            if (successRate < dexterity)
            {
                Console.WriteLine("Successfully meditated. Low XP gained.");
            }
            else
            {
                Console.WriteLine("Meditation failed. No XP gained.");
            }
        }

        public void LightsaberFormPractice(int dexterity)
        {
            int successRate = random.Next(0, 100);
            if (successRate < dexterity)
            {
                Console.WriteLine("Successfully practiced a lightsaber form. Moderate XP gained.");
            }
            else
            {
                Console.WriteLine("Practice failed. Slight energy wasted.");
            }
        }

        public void ForcePushTraining(int dexterity)
        {
            PerformTraining(dexterity, "Force Push Training", 10, 20);
        }

        public void DefenseReflexDrill(int dexterity)
        {
            PerformTraining(dexterity, "Defense Reflex Drill", 5, 10);
        }

        public void ParryPractice(int dexterity)
        {
            PerformTraining(dexterity, "Parry Practice", 8, 15);
        }

        public void AdvancedLightsaberTechniques(int dexterity)
        {
            PerformTraining(dexterity, "Advanced Lightsaber Techniques", 15, 30);
        }

        public void EnhancedForcePull(int dexterity)
        {
            PerformTraining(dexterity, "Enhanced Force Pull", 12, 25);
        }

        public void JumpTraining(int dexterity)
        {
            PerformTraining(dexterity, "Jump Training", 8, 18);
        }

        public void ShadowStealth(int dexterity)
        {
            PerformTraining(dexterity, "Shadow Stealth", 10, 22);
        }

        public void MindControlPractice(int dexterity)
        {
            PerformTraining(dexterity, "Mind Control Practice", 14, 28);
        }

        public void PrecognitionEnhancement(int dexterity)
        {
            PerformTraining(dexterity, "Precognition Enhancement", 10, 20);
        }

        public void ForceChokeTechnique(int dexterity)
        {
            PerformTraining(dexterity, "Force Choke Technique", 18, 35);
        }

        public void SpeedRunTraining(int dexterity)
        {
            PerformTraining(dexterity, "Speed Run Training", 9, 19);
        }

        public void DuelSimulation(int dexterity)
        {
            PerformTraining(dexterity, "Duel Simulation", 20, 40);
        }

        public void ForceShieldCreation(int dexterity)
        {
            PerformTraining(dexterity, "Force Shield Creation", 15, 33);
        }

        public void AdvancedCombatReflex(int dexterity)
        {
            PerformTraining(dexterity, "Advanced Combat Reflex", 17, 36);
        }

        public void TelekinesisMastery(int dexterity)
        {
            PerformTraining(dexterity, "Telekinesis Mastery", 25, 50);
        }

        public void SaberThrowTraining(int dexterity)
        {
            PerformTraining(dexterity, "Saber Throw Training", 13, 27);
        }

        public void ForceSenseExpansion(int dexterity)
        {
            PerformTraining(dexterity, "Force Sense Expansion", 11, 24);
        }

        public void UltimateForceMeditation(int dexterity)
        {
            PerformTraining(dexterity, "Ultimate Force Meditation", 20, 45);
        }

        private void PerformTraining(int dexterity, string activity, int energyCost, int xpGain)
        {
            int successRate = random.Next(0, 100);
            if (successRate < dexterity)
            {
                Console.WriteLine($"Successfully completed {activity}. Gained {xpGain} XP!");
            }
            else
            {
                Console.WriteLine($"{activity} failed. Energy lost: {energyCost}.");

            }
        }
    }
}
