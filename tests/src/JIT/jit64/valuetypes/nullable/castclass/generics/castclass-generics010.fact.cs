using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_generics_castclass_generics010_castclass_generics010_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_generics_castclass_generics010_castclass_generics010_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\generics\\castclass-generics010\\castclass-generics010.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
