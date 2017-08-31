using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__rels_ldsfld_mulovf__rels_ldsfld_mulovf_
    {
        [Fact]
        public void _int64_signed__rels_ldsfld_mulovf__rels_ldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_rels_ldsfld_mulovf\\_rels_ldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
