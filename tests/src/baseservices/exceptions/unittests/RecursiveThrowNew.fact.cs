using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _unittests_RecursiveThrowNew_RecursiveThrowNew_
    {
        [OuterLoop]
        [Fact]
        public void _unittests_RecursiveThrowNew_RecursiveThrowNew_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\unittests\\RecursiveThrowNew\\RecursiveThrowNew.cmd");
        }
    }
}
