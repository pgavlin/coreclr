using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_null_castclass_null037_castclass_null037_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_null_castclass_null037_castclass_null037_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\null\\castclass-null037\\castclass-null037.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
