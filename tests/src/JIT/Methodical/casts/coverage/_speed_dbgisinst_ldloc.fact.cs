using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__speed_dbgisinst_ldloc__speed_dbgisinst_ldloc_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_dbgisinst_ldloc__speed_dbgisinst_ldloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgisinst_ldloc\\_speed_dbgisinst_ldloc.cmd");
        }
    }
}
