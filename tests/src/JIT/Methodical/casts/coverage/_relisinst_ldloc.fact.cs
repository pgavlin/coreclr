using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__relisinst_ldloc__relisinst_ldloc_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__relisinst_ldloc__relisinst_ldloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relisinst_ldloc\\_relisinst_ldloc.cmd");
        }
    }
}
