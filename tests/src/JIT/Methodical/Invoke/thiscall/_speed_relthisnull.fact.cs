using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_thiscall__speed_relthisnull__speed_relthisnull_
    {
        [Fact]
        public void _Invoke_thiscall__speed_relthisnull__speed_relthisnull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\thiscall\\_speed_relthisnull\\_speed_relthisnull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
