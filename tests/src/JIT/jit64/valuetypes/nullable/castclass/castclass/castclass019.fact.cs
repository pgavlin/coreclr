using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_castclass_castclass019_castclass019_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_castclass_castclass019_castclass019_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\castclass\\castclass019\\castclass019.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
