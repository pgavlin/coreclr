using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_null_castclass_null033_castclass_null033_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_null_castclass_null033_castclass_null033_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\null\\castclass-null033\\castclass-null033.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
