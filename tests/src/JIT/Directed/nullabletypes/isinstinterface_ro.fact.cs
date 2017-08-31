using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstinterface_ro_isinstinterface_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_ro_isinstinterface_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_ro\\isinstinterface_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
