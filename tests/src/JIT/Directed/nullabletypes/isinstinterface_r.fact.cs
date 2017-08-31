using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstinterface_r_isinstinterface_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstinterface_r_isinstinterface_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstinterface_r\\isinstinterface_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
