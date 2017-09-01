using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__speed_dbgisinst_newobj__speed_dbgisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_dbgisinst_newobj__speed_dbgisinst_newobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgisinst_newobj\\_speed_dbgisinst_newobj.cmd");
        }
    }
}
