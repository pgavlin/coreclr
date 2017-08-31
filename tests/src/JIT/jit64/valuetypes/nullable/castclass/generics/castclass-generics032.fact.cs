using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_generics_castclass_generics032_castclass_generics032_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_generics_castclass_generics032_castclass_generics032_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\generics\\castclass-generics032\\castclass-generics032.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
