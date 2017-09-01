using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_GoryNativePast_GoryNativePast_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_GoryNativePast_GoryNativePast_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\GoryNativePast\\GoryNativePast.cmd");
        }
    }
}
