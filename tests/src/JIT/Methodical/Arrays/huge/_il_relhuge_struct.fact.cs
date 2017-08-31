using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_huge__il_relhuge_struct__il_relhuge_struct_
    {
        [Fact]
        public void _Arrays_huge__il_relhuge_struct__il_relhuge_struct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\huge\\_il_relhuge_struct\\_il_relhuge_struct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
