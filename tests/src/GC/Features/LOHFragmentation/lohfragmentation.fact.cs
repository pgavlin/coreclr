using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _LOHFragmentation_lohfragmentation_lohfragmentation_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _LOHFragmentation_lohfragmentation_lohfragmentation_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\LOHFragmentation\\lohfragmentation\\lohfragmentation.cmd");
        }
    }
}
