using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_parameterattributes_ParameterAttributesHasDefault_ParameterAttributesHasDefault_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_parameterattributes_ParameterAttributesHasDefault_ParameterAttributesHasDefault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\parameterattributes\\ParameterAttributesHasDefault\\ParameterAttributesHasDefault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
