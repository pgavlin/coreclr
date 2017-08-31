using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_port__il_relhuge_gcref__il_relhuge_gcref_
    {
        [Fact]
        public void _VT_port__il_relhuge_gcref__il_relhuge_gcref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\port\\_il_relhuge_gcref\\_il_relhuge_gcref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
