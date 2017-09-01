using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_oldtests_lclfldadd_cs_ro_lclfldadd_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldadd_cs_ro_lclfldadd_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldadd_cs_ro\\lclfldadd_cs_ro.cmd");
        }
    }
}
