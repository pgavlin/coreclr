using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_castclassinterface_ro_castclassinterface_ro_
    {
        [Fact]
        public void _nullabletypes_castclassinterface_ro_castclassinterface_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\castclassinterface_ro\\castclassinterface_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
