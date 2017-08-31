using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_components
{
    class _stopwatch_Co9600Ctor_Co9600Ctor_
    {
        [OuterLoop]
        [Fact]
        public void _stopwatch_Co9600Ctor_Co9600Ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\components\\stopwatch\\Co9600Ctor\\Co9600Ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
