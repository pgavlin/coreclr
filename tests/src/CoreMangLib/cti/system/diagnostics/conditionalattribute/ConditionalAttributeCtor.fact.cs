using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_diagnostics_conditionalattribute_ConditionalAttributeCtor_ConditionalAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_diagnostics_conditionalattribute_ConditionalAttributeCtor_ConditionalAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\diagnostics\\conditionalattribute\\ConditionalAttributeCtor\\ConditionalAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
