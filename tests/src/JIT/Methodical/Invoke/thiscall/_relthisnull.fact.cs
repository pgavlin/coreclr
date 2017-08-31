using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_thiscall__relthisnull__relthisnull_
    {
        [Fact]
        public void _Invoke_thiscall__relthisnull__relthisnull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\thiscall\\_relthisnull\\_relthisnull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
