using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_interface_castclass_interface003_castclass_interface003_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_interface_castclass_interface003_castclass_interface003_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\interface\\castclass-interface003\\castclass-interface003.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
