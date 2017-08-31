using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_clscompliantattribute_CLSCompliantAttributeCtor_CLSCompliantAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_clscompliantattribute_CLSCompliantAttributeCtor_CLSCompliantAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\clscompliantattribute\\CLSCompliantAttributeCtor\\CLSCompliantAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
