using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _BaseFinal_basefinal_basefinal_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _BaseFinal_basefinal_basefinal_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\BaseFinal\\basefinal\\basefinal.cmd");
        }
    }
}
