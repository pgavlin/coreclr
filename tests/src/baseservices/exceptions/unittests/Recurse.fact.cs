using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_Recurse_Recurse_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_Recurse_Recurse_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\Recurse\\Recurse.cmd");
        }
    }
}
