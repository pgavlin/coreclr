using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_parameterattributes_ParameterAttributesOut_ParameterAttributesOut_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_parameterattributes_ParameterAttributesOut_ParameterAttributesOut_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\parameterattributes\\ParameterAttributesOut\\ParameterAttributesOut.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
