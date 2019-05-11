using DesignPatterns.FactoryMethod.Pages;

namespace DesignPatterns.FactoryMethod
{
    public sealed class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
