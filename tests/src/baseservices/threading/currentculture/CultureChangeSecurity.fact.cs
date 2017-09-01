using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _currentculture_CultureChangeSecurity_CultureChangeSecurity_
    {
        [OuterLoop]
        [Fact]
        public void _currentculture_CultureChangeSecurity_CultureChangeSecurity_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\currentculture\\CultureChangeSecurity\\CultureChangeSecurity.cmd");
        }
    }
}
