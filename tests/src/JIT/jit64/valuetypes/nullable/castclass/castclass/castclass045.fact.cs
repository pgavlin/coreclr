using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_castclass_castclass045_castclass045_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_castclass_castclass045_castclass045_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\castclass\\castclass045\\castclass045.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
