using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_generics_castclass_generics004_castclass_generics004_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_generics_castclass_generics004_castclass_generics004_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\generics\\castclass-generics004\\castclass-generics004.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
