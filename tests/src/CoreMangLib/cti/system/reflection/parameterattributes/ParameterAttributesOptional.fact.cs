using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_parameterattributes_ParameterAttributesOptional_ParameterAttributesOptional_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_parameterattributes_ParameterAttributesOptional_ParameterAttributesOptional_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\parameterattributes\\ParameterAttributesOptional\\ParameterAttributesOptional.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
