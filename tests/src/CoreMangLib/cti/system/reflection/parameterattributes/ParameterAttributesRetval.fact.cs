using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_parameterattributes_ParameterAttributesRetval_ParameterAttributesRetval_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_parameterattributes_ParameterAttributesRetval_ParameterAttributesRetval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\parameterattributes\\ParameterAttributesRetval\\ParameterAttributesRetval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
