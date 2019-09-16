﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigNotebook
{
    /// <summary>
    /// Раздел планы
    /// </summary>
    [Serializable]
    class ClassPlants:ICrypt
    {
        /// <summary>
        /// Планы на будущее
        /// </summary>
        List<FuturePlan> FuturePlans;
        /// <summary>
        /// Цели
        /// </summary>
        List<Target> Targets;
        /// <summary>
        /// Список закупок
        /// </summary>
        List<ShoppingList> ShoppingLists;
        /// <summary>
        /// Проекты
        /// </summary>
        List<Project> Projects;

        ClassPlants()
        {
            FuturePlans = new List<FuturePlan>();
            Targets = new List<Target>();
            ShoppingLists = new List<ShoppingList>();
            Projects = new List<Project>();
        }
        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <returns>Истина, если удачно</returns>
        public bool Decrypt()
        {
            try
            {
                foreach (FuturePlan futurePlan in FuturePlans)
                    futurePlan.Decrypt();
                foreach (Target target in Targets)
                    target.Decrypt();
                foreach (ShoppingList shopping in ShoppingLists)
                    shopping.Decrypt();
                foreach (Project project in Projects)
                    project.Decrypt();

                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// Шифрование
        /// </summary>
        /// <returns>Истина, если удачно</returns>
        public bool Encrypt()
        {
            try
            {
                foreach (FuturePlan futurePlan in FuturePlans)
                    futurePlan.Encrypt();
                foreach (Target target in Targets)
                    target.Encrypt();
                foreach (ShoppingList shopping in ShoppingLists)
                    shopping.Encrypt();
                foreach (Project project in Projects)
                    project.Encrypt();

                return true;
            }
            catch { return false; }
        }

    }

    /// <summary>
    /// Планы на будущее
    /// </summary>
    [Serializable]
    class FuturePlan:ICrypt
    {
        /// <summary>
        /// Название плана
        /// </summary>
        string NamePlan;
        /// <summary>
        /// Дата реализации
        /// </summary>
        DateTime DateRealise;
        /// <summary>
        /// Пункты плана
        /// </summary>
        List<PunktOfPlan> punktOfPlans;

        FuturePlan()
        {
            NamePlan = "";
            DateRealise = DateTime.Now;
            punktOfPlans = new List<PunktOfPlan>();
            
        }

        public bool Decrypt()
        {
            try
            {
                NamePlan = ClassCrypt.Decrypt(NamePlan);
                foreach (PunktOfPlan punkt in punktOfPlans)
                    punkt.Decrypt();

                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NamePlan = ClassCrypt.Encrypt(NamePlan);
                foreach (PunktOfPlan punkt in punktOfPlans)
                    punkt.Encrypt();

                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Пункт Плана
    /// </summary>
    [Serializable]
    class PunktOfPlan:ICrypt
    {
        /// <summary>
        /// № пункта
        /// </summary>
        int NumberPunkt;
        /// <summary>
        /// Название пункта
        /// </summary>
        string NamePunkt;
        /// <summary>
        /// Флаг выполнения
        /// </summary>
        bool CompleteFlag;

        PunktOfPlan()
        {
            NumberPunkt = 0;
            NamePunkt = "";
            CompleteFlag = false;
        }
        public bool Encrypt()
        {
            try
            {
                NamePunkt = ClassCrypt.Encrypt(NamePunkt);
                return true;
            }
            catch { return false; }
        }
        public bool Decrypt()
        {
            try
            {
                NamePunkt = ClassCrypt.Decrypt(NamePunkt);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Шаг достижения цели
    /// </summary>
    [Serializable]
    class Step:ICrypt
    {
        /// <summary>
        /// № шага
        /// </summary>
        int NumberStep;
        /// <summary>
        /// Название шага
        /// </summary>
        string NameStep;
        /// <summary>
        /// Описание шага
        /// </summary>
        string DescriptionStep;
        /// <summary>
        /// продолжительность
        /// </summary>
        DateTime DurationStep;
        /// <summary>
        /// Флаг о завершении
        /// </summary>
        bool CompleteFlag;

        Step()
        {
            NumberStep = 0;
            NameStep = "";
            DescriptionStep = "";
            DurationStep = DateTime.Now;
            CompleteFlag = false;
        }
        public bool Decrypt()
        {
            try
            {
                NameStep = ClassCrypt.Decrypt(NameStep);
                DescriptionStep = ClassCrypt.Decrypt(DescriptionStep);
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameStep = ClassCrypt.Encrypt(NameStep);
                DescriptionStep = ClassCrypt.Encrypt(DescriptionStep);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Цель
    /// </summary>
    [Serializable]
    class Target:ICrypt
    {
        /// <summary>
        /// название
        /// </summary>
        string NameTarget;
        /// <summary>
        /// Дата начала реализации
        /// </summary>
        DateTime DateStartRealise;
        /// <summary>
        /// Дата окончания реализации
        /// </summary>
        DateTime DateEndRealise;
        /// <summary>
        /// Описание
        /// </summary>
        string DescriptionTarget;
        /// <summary>
        /// Шаги достижения
        /// </summary>
        List<Step> Steps;
        /// <summary>
        /// Отметка о достижении
        /// </summary>
        bool CompleteFlag;

        Target()
        {
            NameTarget = "";
            DateStartRealise = DateTime.Now;
            DateEndRealise = DateTime.Now;
            DescriptionTarget = "";
            Steps = new List<Step>();
            CompleteFlag = false;
        }
        public bool Decrypt()
        {
            try
            {
                NameTarget = ClassCrypt.Decrypt(NameTarget);
                DescriptionTarget = ClassCrypt.Decrypt(DescriptionTarget);
                foreach (Step step in Steps)
                    step.Decrypt();
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameTarget = ClassCrypt.Encrypt(NameTarget);
                DescriptionTarget = ClassCrypt.Encrypt(DescriptionTarget);
                foreach (Step step in Steps)
                    step.Encrypt();
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Список покупок
    /// </summary>
    [Serializable]
    class ShoppingList:ICrypt
    {
        /// <summary>
        /// Название
        /// </summary>
        string NameItem;
        /// <summary>
        /// Описание
        /// </summary>
        string Description;
        /// <summary>
        ///Цена
        /// </summary>
        double Cost;
        /// <summary>
        /// Отметка о покупке
        /// </summary>
        bool CompleteFlag;

        ShoppingList()
        {
            NameItem = "";
            Description = "";
            Cost = 0;
            CompleteFlag = false;
        }
        public bool Decrypt()
        {
            try
            {
                NameItem = ClassCrypt.Decrypt(NameItem);
                Description = ClassCrypt.Decrypt(Description);
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameItem = ClassCrypt.Encrypt(NameItem);
                Description = ClassCrypt.Encrypt(Description);
                return true;
            }
            catch { return false; }
        }
    }

    /// <summary>
    /// Проекты
    /// </summary>
    [Serializable]
    class Project:ICrypt
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        string NameProject;
        /// <summary>
        /// Описание
        /// </summary>
        string Description;
        /// <summary>
        /// Дата начала
        /// </summary>
        DateTime DateStart;
        /// <summary>
        /// Шаги реализации
        /// </summary>
        List<ProjectStep> ProjectSteps;

        Project()
        {
            NameProject = "";
            Description = "";
            DateStart = DateTime.Now;
            ProjectSteps = new List<ProjectStep>();
        }
        public bool Decrypt()
        {
            try
            {
                NameProject = ClassCrypt.Decrypt(NameProject);
                Description = ClassCrypt.Decrypt(Description);
                foreach (ProjectStep step in ProjectSteps)
                    step.Decrypt();
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameProject = ClassCrypt.Encrypt(NameProject);
                Description = ClassCrypt.Encrypt(Description);
                foreach (ProjectStep step in ProjectSteps)
                    step.Encrypt();
                return true;
            }
            catch { return false; }
        }

    }

    [Serializable]
    /// <summary>
    /// пункт реализации проекта
    /// </summary>
    class ProjectStep:ICrypt
    {
        /// <summary>
        /// наименование
        /// </summary>
        string NameStep;
        /// <summary>
        /// Описание
        /// </summary>
        string Description;
        /// <summary>
        /// Отметка о выполнении
        /// </summary>
        bool CombleteFlag;

        ProjectStep()
        {
            NameStep = "";
            Description = "";
            CombleteFlag = false;
        }
        public bool Decrypt()
        {
            try
            {
                NameStep = ClassCrypt.Decrypt(NameStep);
                Description = ClassCrypt.Decrypt(Description);
                return true;
            }
            catch { return false; }
        }
        public bool Encrypt()
        {
            try
            {
                NameStep = ClassCrypt.Encrypt(NameStep);
                Description = ClassCrypt.Encrypt(Description);
                return true;
            }
            catch { return false; }
        }
    }



}
