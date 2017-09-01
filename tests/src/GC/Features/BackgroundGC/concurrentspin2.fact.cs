using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _BackgroundGC_concurrentspin2_concurrentspin2_
    {
        [OuterLoop]
        [Fact]
        public void _BackgroundGC_concurrentspin2_concurrentspin2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\BackgroundGC\\concurrentspin2\\concurrentspin2.cmd");
        }
    }
}
