using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_vswhidbey_148190_baduwinfo_baduwinfo_
    {
        [OuterLoop]
        [Fact]
        public void _eh_regress_vswhidbey_148190_baduwinfo_baduwinfo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\vswhidbey\\148190\\baduwinfo\\baduwinfo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
