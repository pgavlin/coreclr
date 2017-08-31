using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _PartialCompaction_partialcompactiontest_partialcompactiontest_
    {
        [OuterLoop]
        [Fact]
        public void _PartialCompaction_partialcompactiontest_partialcompactiontest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\PartialCompaction\\partialcompactiontest\\partialcompactiontest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
