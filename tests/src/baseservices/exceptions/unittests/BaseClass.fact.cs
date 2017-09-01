using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_BaseClass_BaseClass_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_BaseClass_BaseClass_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\BaseClass\\BaseClass.cmd");
        }
    }
}
