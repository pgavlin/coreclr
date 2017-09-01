using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_oldtests_lclfldmul_cs_ro_lclfldmul_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldmul_cs_ro_lclfldmul_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldmul_cs_ro\\lclfldmul_cs_ro.cmd");
        }
    }
}
