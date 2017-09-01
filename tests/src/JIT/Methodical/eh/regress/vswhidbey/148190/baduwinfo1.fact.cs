using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_regress_vswhidbey_148190_baduwinfo1_baduwinfo1_
    {
        [OuterLoop]
        [Fact]
        public void _eh_regress_vswhidbey_148190_baduwinfo1_baduwinfo1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\vswhidbey\\148190\\baduwinfo1\\baduwinfo1.cmd");
        }
    }
}
