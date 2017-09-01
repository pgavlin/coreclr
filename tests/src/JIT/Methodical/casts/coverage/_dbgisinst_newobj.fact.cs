using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__dbgisinst_newobj__dbgisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__dbgisinst_newobj__dbgisinst_newobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgisinst_newobj\\_dbgisinst_newobj.cmd");
        }
    }
}
