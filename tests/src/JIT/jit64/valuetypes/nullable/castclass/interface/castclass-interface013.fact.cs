using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _valuetypes_nullable_castclass_interface_castclass_interface013_castclass_interface013_
    {
        [OuterLoop]
        [Fact]
        public void _valuetypes_nullable_castclass_interface_castclass_interface013_castclass_interface013_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\valuetypes\\nullable\\castclass\\interface\\castclass-interface013\\castclass-interface013.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
