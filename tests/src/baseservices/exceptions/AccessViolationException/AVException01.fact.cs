using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    public class _AccessViolationException_AVException01_AVException01_
    {
        [OuterLoop]
        [Fact]
        public void _AccessViolationException_AVException01_AVException01_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\exceptions\\AccessViolationException\\AVException01\\AVException01.cmd");
        }
    }
}
