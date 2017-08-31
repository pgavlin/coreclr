using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHFragmentation_lohfragmentation_lohfragmentation_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _LOHFragmentation_lohfragmentation_lohfragmentation_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHFragmentation\\lohfragmentation\\lohfragmentation.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
