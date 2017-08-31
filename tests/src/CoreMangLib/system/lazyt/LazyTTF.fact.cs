using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _lazyt_LazyTTF_LazyTTF_
    {
        [OuterLoop]
        [Fact]
        public void _lazyt_LazyTTF_LazyTTF_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\lazyt\\LazyTTF\\LazyTTF.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
