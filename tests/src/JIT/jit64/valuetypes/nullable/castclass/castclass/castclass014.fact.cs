using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_castclass_castclass014_castclass014_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_castclass_castclass014_castclass014_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\castclass\\castclass014\\castclass014.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
