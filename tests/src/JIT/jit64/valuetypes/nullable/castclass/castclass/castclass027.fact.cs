using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_castclass_castclass027_castclass027_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_castclass_castclass027_castclass027_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\castclass\\castclass027\\castclass027.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
