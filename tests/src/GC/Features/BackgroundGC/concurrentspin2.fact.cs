using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _BackgroundGC_concurrentspin2_concurrentspin2_
    {
        [OuterLoop]
        [Fact]
        public void _BackgroundGC_concurrentspin2_concurrentspin2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\BackgroundGC\\concurrentspin2\\concurrentspin2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
