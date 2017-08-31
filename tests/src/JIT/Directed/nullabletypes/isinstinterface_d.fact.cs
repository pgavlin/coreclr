using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstinterface_d_isinstinterface_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_d_isinstinterface_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_d\\isinstinterface_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
