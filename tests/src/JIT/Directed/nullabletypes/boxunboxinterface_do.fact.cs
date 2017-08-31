using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_boxunboxinterface_do_boxunboxinterface_do_
    {
        [Fact]
        public void _nullabletypes_boxunboxinterface_do_boxunboxinterface_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\boxunboxinterface_do\\boxunboxinterface_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
