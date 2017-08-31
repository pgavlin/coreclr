using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    class _FastTailCall_StructPassingSimple_StructPassingSimple_
    {
        [Fact]
        public void _FastTailCall_StructPassingSimple_StructPassingSimple_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\StructPassingSimple\\StructPassingSimple.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
