using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_clscompliantattribute_CLSCompliantAttributeIsCompliant_CLSCompliantAttributeIsCompliant_
    {
        [OuterLoop]
        [Fact]
        public void _system_clscompliantattribute_CLSCompliantAttributeIsCompliant_CLSCompliantAttributeIsCompliant_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\clscompliantattribute\\CLSCompliantAttributeIsCompliant\\CLSCompliantAttributeIsCompliant.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
