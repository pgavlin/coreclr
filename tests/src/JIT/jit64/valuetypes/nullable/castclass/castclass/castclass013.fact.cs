using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_castclass_castclass013_castclass013_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_castclass_castclass013_castclass013_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\castclass\\castclass013\\castclass013.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
